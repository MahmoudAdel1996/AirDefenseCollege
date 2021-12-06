using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SautinSoft.Document;
namespace Nozom.Api.Helper
{
    public class EditOnDocument2AT
    {
        public void AddProductsNamesWithQuantity(string names, int quantity) {
            var loadPath = @"E:\Mahmoud Adel\NozomApp\Nozom\Nozom.Api\2AT.docx";
            var resultPath = @"E:\Mahmoud Adel\NozomApp\Nozom\Nozom.Api\2ATResult.docx";
            var dc = DocumentCore.Load(loadPath);

            var productName = new Regex(@"<productName>", RegexOptions.IgnoreCase);
            var productQuantity = new Regex(@"<quantity>", RegexOptions.IgnoreCase);

            foreach (ContentRange item in dc.Content.Find(productName))
            {
                item.Replace(names, new CharacterFormat());
            }
            foreach (ContentRange item in dc.Content.Find(productQuantity))
            {
                item.Replace(quantity.ToString(), new CharacterFormat());
            }

            dc.Save(resultPath, SaveOptions.DocxDefault);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(resultPath) { UseShellExecute = true });
        }

    }
}
