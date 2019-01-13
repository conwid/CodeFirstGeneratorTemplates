using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using System.Data.Entity.SqlServer;

namespace $rootnamespace$
{
    // Don't forget to add an instance of this class to your DbConfiguration descendant's constructor
    // SetSqlGenerator("System.Data.SqlClient", new $safeitemrootname$(this));                    
    
    // Override the methods to add custom generation steps to a specific model element
    // see https://github.com/aspnet/EntityFramework6/blob/master/src/EntityFramework.SqlServer/SqlServerMigrationSqlGenerator.cs 
    internal class $safeitemrootname$ : SqlServerMigrationGenerator
	{
	}
}
