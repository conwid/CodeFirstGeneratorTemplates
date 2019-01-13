using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
    // Don't forget to add an instance of this class to your DbConfiguration descendant's constructor
    // this.CodeGenerator = new $safeitemrootname$();
    
    // Override the methods to add custom generation steps to a specific model element
    // see https://github.com/aspnet/EntityFramework6/blob/master/src/EntityFramework/Migrations/Design/CSharpMigrationCodeGenerator.cs
	internal class $safeitemrootname$ : CSharpMigrationCodeGenerator
	{
	}
}
