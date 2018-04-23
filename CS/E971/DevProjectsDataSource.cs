using System;
using System.Collections.Generic;

    public class DevProjectsDataStore {
        Dictionary<int, DevProjectsGoal> goalsCore;
        List<DevProject> projects;
        //
        public DevProjectsDataStore() {
            goalsCore = new Dictionary<int, DevProjectsGoal>();
            projects = new List<DevProject>();
            //
            AddGoal(new DevProjectsGoal(2007, 150));
            AddGoal(new DevProjectsGoal(2008, 175));
            //
            AddProject(new DevProject(2007, 37));
            AddProject(new DevProject(2007, 41));
            AddProject(new DevProject(2007, 17));

            AddProject(new DevProject(2008, 53));
            AddProject(new DevProject(2008, 18));
            AddProject(new DevProject(2008, 62));
            AddProject(new DevProject(2008, 33));
        }
        protected void AddGoal(DevProjectsGoal goal) {
            if (!Goals.ContainsKey(goal.Year)) Goals.Add(goal.Year, goal);
        }
        protected void AddProject(DevProject project) {
            Projects.Add(project);
        }
        protected Dictionary<int, DevProjectsGoal> Goals {
            get { return goalsCore; }
        }
        protected List<DevProject> Projects {
            get { return projects; }
        }
        public DevProjectsGoal SelectFromGoalsWhereYearAreEqual(int year) {
            DevProjectsGoal result = null;
            Goals.TryGetValue(year, out result);
            return result;
        }
        public DevProject[] SelectFromProjectsWhereYearAreEqual(int year) {
            List<DevProject> result = new List<DevProject>();
            foreach (DevProject p in Projects) {
                if (p.Year == year) result.Add(p);
            }
            return result.ToArray();
        }
    }
    public class DevProjectsGoal {
        int yearCore;
        int goalCore;
        //
        public DevProjectsGoal(int year, int goal) {
            yearCore = year;
            goalCore = goal;
        }
        public int Year {
            get { return yearCore; }
            set { yearCore = value; }
        }
        public int Goal {
            get { return goalCore; }
            set { goalCore = value; }
        }
    }
public class DevProject {
    int yearCore;
    int valueCore;
    public DevProject(int year, int value) {
        yearCore = year;
        valueCore = value;
    }
    public int Year {
        get { return yearCore; }
        set { yearCore = value; }
    }
    public int Value {
        get { return valueCore; }
        set { valueCore = value; }
    }
}