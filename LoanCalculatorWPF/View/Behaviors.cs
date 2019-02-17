using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Interactivity;

namespace LoanCalculatorWPF.View
{
    public class AboutBoxOpen : Behavior<MenuItem>
    {
        protected override void OnAttached()
        {
            Window parent = Application.Current.MainWindow;

            AssociatedObject.Click += (sender, e) =>
            {
                AboutWindow about = new AboutWindow();
                about.ShowDialog();
            };
        }
    }

    public class PrintClick : Behavior<Window>
    {
        public static readonly DependencyProperty PrzyciskProperty = DependencyProperty.Register("Btn", typeof(Button), typeof(PrintClick), new PropertyMetadata(null, ButtonPrint));        
        public static readonly DependencyProperty DocumentProperty = DependencyProperty.Register("Document", typeof(FlowDocument), typeof(PrintClick));

        public Button Btn
        {
            get { return (Button)GetValue(PrzyciskProperty); }
            set { SetValue(PrzyciskProperty, value); }
        }
        public FlowDocument Document
        {
            get { return (FlowDocument)GetValue(DocumentProperty); }
            set { SetValue(DocumentProperty, value); }
        }

        private static void ButtonPrint(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {                
                RoutedEventHandler button_Click = (object sender, RoutedEventArgs _e) =>
                {                                      
                    PrintDialog printDlg = new PrintDialog();
                    IDocumentPaginatorSource idpSource = (d as PrintClick).Document;
                    printDlg.PrintDocument(idpSource.DocumentPaginator, "printing...");                    
                };
                if (e.OldValue != null)
                    ((Button)e.OldValue).Click -= button_Click;
                if (e.NewValue != null)
                    ((Button)e.NewValue).Click += button_Click;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
