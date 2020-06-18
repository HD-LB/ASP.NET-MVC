using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Injection_Example
{
    class SqlInjectionPrevention
    {
        static void Main(string[] args)
        {
            protected void ButtonSearch_Cklick(object sender, EventArgs e)
            {
                //This search wroks correctly, no SQL injection is possible
                const string SearchSql = @"SELECT * FROM messages WHERE messageTexyt LIKE {0} ESCAPE '~'";
                var serchString = "%" + this.TextBoxSerach.Text.Replace("~", "~~").Replace("%", "~%") + "%";
                var context = new MessageDbContext();
                var matchingMessages = context.Databese.SqlQuery<matchingMessages>(SearchSql, searchString).ToList();
                this.ListViewMessages.DataSource = matchingMessages;
                this.DataBind();
            }
        }
    }
}
