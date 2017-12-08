using RPGItemGenerator.ItemGeneration;
using RPGItemGenerator.ItemGeneration.GenerationMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ItemDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
        public MainWindow()
        {
            InitializeComponent();
            itemSubTypeLabel.Visibility = Visibility.Hidden;
            itemSubTypeSelector.Visibility = Visibility.Hidden;
            weaponSubSubLabel.Visibility = Visibility.Hidden;
            weaponSubSubSelector.Visibility = Visibility.Hidden;
        }      

        private void itemTypeSelector_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox send = (ComboBox)sender;
            if (send.SelectionBoxItem.ToString() == "Weapon" ||
                send.SelectionBoxItem.ToString() == "Armor" ||
                send.SelectionBoxItem.ToString() == "Jewelry")
            {
                itemSubTypeLabel.Visibility = Visibility.Visible;
                itemSubTypeSelector.Visibility = Visibility.Visible;
                weaponSubSubLabel.Visibility = Visibility.Hidden;
                weaponSubSubSelector.Visibility = Visibility.Hidden;
                FillInSubTypeSelector(send.SelectionBoxItem.ToString());
            }
            else
            {
                itemSubTypeLabel.Visibility = Visibility.Hidden;
                itemSubTypeSelector.Visibility = Visibility.Hidden;
                weaponSubSubLabel.Visibility = Visibility.Hidden;
                weaponSubSubSelector.Visibility = Visibility.Hidden;
            }            
        }

        private void FillInSubTypeSelector(string ChosenType)
        {
            switch (ChosenType)
            {
                case "Weapon":
                    {
                        string[] weaponTypes = { "Melee", "Magic", "Ranged" };
                        itemSubTypeSelector.ItemsSource = weaponTypes;
                        break;
                    }
                case "Armor":
                    {
                        string[] armorTypes = { "Helm", "Boots", "Chest", "Gloves", "Leggings", "Pauldrons", "Shield" };
                        itemSubTypeSelector.ItemsSource = armorTypes;
                        break;
                    }
                case "Jewelry":
                    {
                        string[] jewelryTypes = { "Neck", "Finger", "Wrist", "Ear" };
                        itemSubTypeSelector.ItemsSource = jewelryTypes;
                        break;
                    }
            }            
        }

        private void itemSubTypeSelector_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox send = (ComboBox)sender;
            if (send.SelectionBoxItem.ToString() == "Melee" ||
                send.SelectionBoxItem.ToString() == "Magic" ||
                send.SelectionBoxItem.ToString() == "Ranged")
            {
                weaponSubSubLabel.Visibility = Visibility.Visible;
                weaponSubSubSelector.Visibility = Visibility.Visible;
                FillInWeaponSubSubTypeSelector(send.SelectionBoxItem.ToString());
            }
            else
            {
                weaponSubSubLabel.Visibility = Visibility.Hidden;
                weaponSubSubSelector.Visibility = Visibility.Hidden;
            }
        }

        private void FillInWeaponSubSubTypeSelector(string ChosenType)
        {
            switch (ChosenType)
            {
                case "Melee":
                    {
                        string[] meleeTypes = { "Dagger", "Spear", "Sword" };
                        weaponSubSubSelector.ItemsSource = meleeTypes;
                        break;
                    }
                case "Magic":
                    {
                        string[] magicTypes = { "Spellbook", "Staff", "Wand" };
                        weaponSubSubSelector.ItemsSource = magicTypes;
                        break;
                    }
                case "Ranged":
                    {
                        string[] rangedTypes = { "Bow", "Crossbow" };
                        weaponSubSubSelector.ItemsSource = rangedTypes;
                        break;
                    }
            }
        }        

        private void raritySelector_Initialized(object sender, EventArgs e)
        {
            string[] rarityOptions = { "Common", "Uncommon", "Rare", "Epic", "Legendary" };
            raritySelector.ItemsSource = rarityOptions;
        }

        private void itemTypeSelector_Initialized(object sender, EventArgs e)
        {
            string[] itemTypes = {"Armor", "Jewelry", "Potion", "Weapon" };
            itemTypeSelector.ItemsSource = itemTypes;
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            string rarity = raritySelector.SelectionBoxItem.ToString();
            string baseType = itemTypeSelector.SelectionBoxItem.ToString();
            string subType = itemSubTypeSelector.SelectionBoxItem.ToString();
            string weaponSubType = weaponSubSubSelector.SelectionBoxItem.ToString();

            if(rarity == "")
            {
                rarity = "Common";
            }
            if(baseType == "")
            {
                baseType = "Weapon";
            }
            if(subType == "" && baseType == "Weapon")
            {
                subType = "Melee";
            }
            if (subType == "" && baseType == "Armor")
            {
                subType = "Helm";
            }
            if (subType == "" && baseType == "Jewelry")
            {
                subType = "Ring";
            }
            if(weaponSubType == "" && baseType == "Weapon")
            {
                weaponSubType = "Sword";
            }

            string formResults = $"{rarity};{baseType};{subType};{weaponSubType}";
            var uiDesigner = new UIDesignerCalls();
            Item generatedResultItem = uiDesigner.GenerateItemFromForm(formResults);

            testLabel.Content = generatedResultItem.Name;
        }
    }
}
