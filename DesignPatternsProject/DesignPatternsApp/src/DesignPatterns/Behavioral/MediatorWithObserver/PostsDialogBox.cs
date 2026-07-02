using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithObserver.UIFramework;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithObserver
{
    public class PostsDialogBox
    {
        private ListBox _postsListBox;
        private TextBox _titleTextBox;      
        private Button _saveButton;

        public PostsDialogBox()
        {
            _postsListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _postsListBox.AddEventHandler(OnPostSelected);
            _titleTextBox.AddEventHandler(OnTitleChanged);
        }
        
        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 1");
            _titleTextBox.SetText("New Title");
            _saveButton.SetEnabled(true);
            Console.WriteLine("Title entered: " + _titleTextBox.GetText());
            Console.WriteLine("Post selected: " + _postsListBox.GetSelection());
            Console.WriteLine($"Save button enabled: {_saveButton.IsEnabled()}");
        }

        private void OnTitleChanged()
        {
             var title = _titleTextBox.GetText();
            var isValid = !string.IsNullOrEmpty(title);
            _saveButton.SetEnabled(isValid);
        }

        private void OnPostSelected()
        {
            var selection = _postsListBox.GetSelection();
            var isValid = !string.IsNullOrEmpty(selection);
            _saveButton.SetEnabled(isValid);
        }
    }
}