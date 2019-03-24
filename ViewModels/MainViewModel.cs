using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
   
    public class MainViewModel:ViewModelBase
    {

        protected virtual IDocumentManagerService DocumentManagerService { get { return null; } }

        public DelegateCommand<string> ShowDocumentCommand => new DelegateCommand<string>(OnShowDocument,true);

        private void OnShowDocument(string documentName)
        {
            var doc = DocumentManagerService.FindDocumentById(documentName);
            if (doc == null)
            {
                doc = DocumentManagerService.CreateDocument(documentName, null, this);
                doc.Id = documentName;
            }
            doc.Show();
        }

        public static MainViewModel Create()
        {
            var factory = ViewModelSource.Factory(() => new MainViewModel());
            return factory();
        }
    }
}
