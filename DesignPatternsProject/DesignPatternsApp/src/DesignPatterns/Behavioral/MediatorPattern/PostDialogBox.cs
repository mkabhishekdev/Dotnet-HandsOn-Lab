using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern
{
    public class PostDialogBox : DialogBox
    {
        private TextBox _titleTextBox;
        private ListBox _postslistBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _titleTextBox = new TextBox(this);
            _postslistBox = new ListBox(this);
            _saveButton = new Button(this);
            _saveButton.SetEnabled(false);
        }
        
        public void SimulateUserInteraction()
        {
            Console.WriteLine("Simulating user interaction with the PostDialogBox...");

            // User enters a title
            _titleTextBox.SetText("My First Post");
            Console.WriteLine($"Title entered: {_titleTextBox.GetText()}");
            Console.WriteLine($"Save button enabled: {_saveButton.IsEnabled()}");

            // User selects a post from the list
            _postslistBox.SetSelection("Post 1");
            Console.WriteLine($"Post selected: {_postslistBox.GetSelection()}");
            Console.WriteLine($"Save button enabled: {_saveButton.IsEnabled()}");

            // User clears the title
            _titleTextBox.SetText("");
            Console.WriteLine($"Title cleared: {_titleTextBox.GetText()}");
            Console.WriteLine($"Save button enabled: {_saveButton.IsEnabled()}");
        }
        
        public override void Changed(UIControl control)
        {
            if (control == _titleTextBox)
            {
                HandleTitleChanged();
            }
            else if (control == _postslistBox)
            {
                HandlePostChanged();
            }
        }

        private void HandleTitleChanged()
        {
            var title = _titleTextBox.GetText();
            var isValid = !string.IsNullOrEmpty(title);
            _saveButton.SetEnabled(isValid);
        }

        private void HandlePostChanged()
        {
            var selection = _postslistBox.GetSelection();
            var isValid = !string.IsNullOrEmpty(selection);
            _saveButton.SetEnabled(isValid);
        }
    }
}