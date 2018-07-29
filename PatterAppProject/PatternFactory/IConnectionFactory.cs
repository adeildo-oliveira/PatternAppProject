using System.Data;

namespace PatterAppProject.PatternFactory
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
