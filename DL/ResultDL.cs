using MID.DL;
using System.Data;
using System.Data.SqlClient;

class ResultDL
{
    private static DBConfig dBConfig = new();
    // Functions to Fill combo boxes
    public static List<string> GetStudentRegNos()
    {
        string query = "SELECT RegistrationNumber FROM Student";
        DataTable dt = dBConfig.GetData(query);
        List<string> regNos = new();
        foreach (DataRow dr in dt.Rows)
        {
            regNos.Add(dr["RegistrationNumber"].ToString());
        }
        return regNos;
    }
    public static List<string> GetAssessmentTitle()
    {
        string query = "SELECT Title FROM Assessment";
        DataTable dt = dBConfig.GetData(query);
        List<string> titles = new();
        foreach (DataRow dr in dt.Rows)
        {
            titles.Add(dr["Title"].ToString());
        }
        return titles;
    }
    public static List<string> GetAssessmentComponentNames(string AssessmentTitle)
    {
        string query = "SELECT Name FROM AssessmentComponent WHERE AssessmentId = (SELECT Id FROM Assessment WHERE Title = '" + AssessmentTitle + "')";
        DataTable dt = dBConfig.GetData(query);
        List<string> names = new();
        foreach (DataRow dr in dt.Rows)
        {
            names.Add(dr["Name"].ToString());
        }
        return names;
    }
    public static List<string> GetRubricDetails(string ComponentName)
    {
        string query = "SELECT Details FROM Rubric WHERE Id = (SELECT RubricId FROM AssessmentComponent WHERE Name = '" + ComponentName + "')";
        DataTable dt = dBConfig.GetData(query);
        List<string> details = new();
        foreach (DataRow dr in dt.Rows)
        {
            details.Add(dr["Details"].ToString());
        }
        return details;
    }
    public static List<int> GetRubricMeasurementLevel(string RubricDetails)
    {
        string query = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = (SELECT Id FROM Rubric WHERE Details = '" + RubricDetails + "')";
        DataTable dt = dBConfig.GetData(query);
        List<int> levels = new();
        foreach (DataRow dr in dt.Rows)
        {
            levels.Add(Convert.ToInt32(dr["MeasurementLevel"]));
        }
        return levels;
    }
    public static bool SaveResult(ResultBL result)
    {
        string query = "Insert into Result(StudentID, AssessmentComponentID, RubricMeasurementId, EvaluationDate) values(@StudentID, @AssessmentComponentID, @RubricLevelID, @EvaluationDate)";
        SqlCommand cmd = new SqlCommand(query, dBConfig.GetConnection());
        cmd.Parameters.AddWithValue("@StudentID", result.GetStudentID());
        cmd.Parameters.AddWithValue("@AssessmentComponentID", result.GetAssessmentComponentId());
        cmd.Parameters.AddWithValue("@RubricLevelID", result.GetRubricLevelId());
        cmd.Parameters.AddWithValue("@EvaluationDate", result.GetEvaluationDate());
        return dBConfig.ExecuteCommand(cmd);
    }
    public static List<ResultBL> GetResults()
    {
        string query = "Select s.RegistrationNumber, a.Title As Assessment, ac.Name As Component, r.Details As Rubric, rl.MeasurementLevel As Level, re.EvaluationDate from StudentResult re join Student s on re.StudentID = s.Id join AssessmentComponent ac on re.AssessmentComponentID = ac.Id join Assessment a on ac.AssessmentId = a.Id join Rubric r on re.RubricMeasurementId = r.Id join RubricLevel rl on r.Id = rl.RubricId";
        List<ResultBL> results = new();
        DataTable dt = dBConfig.GetData(query);
        foreach (DataRow dr in dt.Rows)
        {
            ResultBL result = new(dr["RegistrationNumber"].ToString(), dr["Assessment"].ToString(), dr["Component"].ToString(), dr["Rubric"].ToString(), Convert.ToInt32(dr["Level"]), Convert.ToDateTime(dr["EvaluationDate"]));
            result.CalculateMarks();
            results.Add(result);
        }
        return results;
    }

}