using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class WeeshesEventsFlowForm : MasterDetailPage
    {
        public WeeshesEventsFlowForm()
        {
            InitializeComponent();
            mainTable.Intent = TableIntent.Form;
            mainTable.Root = new TableRoot("Table Title") {
                    new TableSection ("Section 1 Title") {
                        new TextCell {
                            Text = "TextCell Text",
                            Detail = "TextCell Detail"
                        },
                        new EntryCell {
                            Label = "EntryCell:",
                            Placeholder = "default keyboard",
                            Keyboard = Keyboard.Default
                        }
                    },
                    new TableSection ("Section 2 Title") {
                        new EntryCell {
                            Label = "Another EntryCell:",
                            Placeholder = "phone keyboard",
                            Keyboard = Keyboard.Telephone
                        },
                        new SwitchCell {
                            Text = "SwitchCell:"
                        }
                    }
                };
            lblHello.Text = "Cocolito";
        }
    }
}
