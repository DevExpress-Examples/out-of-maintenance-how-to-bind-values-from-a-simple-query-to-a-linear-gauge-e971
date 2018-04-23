using System;
using System.Data;
using System.Collections;
using System.Web.UI.WebControls;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            lGauge1.Scales[0].MaxValue = DSAdapter.RetrieveMaxGoalFromDataSource("year", "2008");
            lGauge1.Scales[0].Value = DSAdapter.RetrieveSumProjectValuesFromDataSource("year", "2008");
        }
    }
}
public class DSAdapter {
    static ObjectDataSource objectDataSource;
    static DSAdapter() {
        objectDataSource = new ObjectDataSource();
        objectDataSource.TypeName = "DevProjectsDataStore";
    }
    public static int RetrieveMaxGoalFromDataSource(string param, string value) {
        object[] queryResult = GetSelectQueryResult(objectDataSource, "SelectFromGoalsWhereYearAreEqual", param, value) as object[];
        return (queryResult != null && queryResult.Length > 0) ? ((DevProjectsGoal)queryResult[0]).Goal : 200;
    }
    public static int RetrieveSumProjectValuesFromDataSource(string param, string value) {
        DevProject[] queryResult = GetSelectQueryResult(objectDataSource, "SelectFromProjectsWhereYearAreEqual", param, value) as DevProject[];
        int result = 0;
        if ((queryResult != null && queryResult.Length > 0)) {
            for (int i = 0; i < queryResult.Length; i++) result += queryResult[i].Value;
        }
        return result;
    }
    static object GetSelectQueryResult(ObjectDataSource ds, string method, string param, string value) {
        ds.SelectParameters.Clear();
        ds.SelectMethod = method;
        ds.SelectParameters.Add(param, value);
        return ds.Select();
    }
}