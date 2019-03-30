using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FlatmateFinders.Common
{
    public static class FFCommon
    {

        public static List<ListButtonModel> StayListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= "  1 month or less " , Selected=false },
                    new ListButtonModel(){ Text= "  2 to 3 months " , Selected=false },
                    new ListButtonModel(){ Text= "  4 to 5 months " , Selected=false }
                };
            }
        }

        public static List<ListButtonModel> AdultListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= " One-Person ", Selected=false },
                    new ListButtonModel(){ Text= " Couple ", Selected=false },
                };
            }
        }

        public static List<ListButtonModel> GenderListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= " Female, straight ", Selected=false },
                    new ListButtonModel(){ Text= " Male, straight ", Selected=false },
                    new ListButtonModel(){ Text= " Female, lesbian / bi ", Selected=false },
                    new ListButtonModel(){ Text= " Male, gay/bi ", Selected=false },

                };
            }
        }

        public static List<string> ContactPersonList
        {
            get
            {
                return new List<String>()
                {
                    " I'm described in the profile ",
                    " I'm a friend or relative ",
                    " I'm the landlord or agent ",
                    " I'm the person moving out ",
                };
            }
        }

        public static List<ListButtonModel> PetListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= " No cat or dog ", Selected=false },
                    new ListButtonModel(){ Text= " Have a cat ", Selected=false },
                    new ListButtonModel(){ Text= " Have a dog ", Selected=false },
                    new ListButtonModel(){ Text= " Have a cat and dog ", Selected=false },

                };
            }
        }

        public static List<ListButtonModel> AgeListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= " 18 to 24 ", Selected=false },
                    new ListButtonModel(){ Text= " 25 to 30 ", Selected=false },
                    new ListButtonModel(){ Text= " 31 to 35 ", Selected=false },
                    new ListButtonModel(){ Text= " 36 to 40 ", Selected=false },
                    new ListButtonModel(){ Text= " 41 years or over ", Selected=false },
                };
            }
        }

        public static List<ListButtonModel> EmployementListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel(){ Text= " Fully employed ", Selected=false },
                    new ListButtonModel(){ Text= " Work part-time ", Selected=false },
                    new ListButtonModel(){ Text= " Studying ", Selected=false },
                };
            }
        }

        public static List<ListButtonModel> SmokingListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Non - smoker ", Selected = false },
                    new ListButtonModel() { Text = " Outdoor smoker ", Selected = false },
                    new ListButtonModel() { Text = " Indoor smoker " , Selected = false },
                };
            }
        }

        public static List<ListButtonModel> HomeTypeListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " House ", Selected = false },
                    new ListButtonModel() { Text = " Apartment ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> HomeSizeListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " 1 bedder/studio ", Selected = false },
                    new ListButtonModel() { Text = " 2 bedroom ", Selected = false },
                    new ListButtonModel() { Text = " 3 bedroom ", Selected = false },
                    new ListButtonModel() { Text = " 4+ bedrooms ", Selected = false }
                };
            }
        }

        public static List<ListButtonModel> OffStreetListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Covered off-street ", Selected = false },
                    new ListButtonModel() { Text = " Uncovered off-street ", Selected = false },
                    new ListButtonModel() { Text = " No off-street parking ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> IncludeBillsListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Exclude bills ", Selected = false },
                    new ListButtonModel() { Text = " Include bills ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> BondListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " 2 weeks ", Selected = false },
                    new ListButtonModel() { Text = " 1 month ", Selected = false },
                    new ListButtonModel() { Text = " Discuss ", Selected = false },
                    new ListButtonModel() { Text = " No bond ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> RoomTypeListButtons
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Private ", Selected = false },
                    new ListButtonModel() { Text = " Shared ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> NumberOfBedsListButton
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " 1 ", Selected = false },
                    new ListButtonModel() { Text = " 2 ", Selected = false },
                    new ListButtonModel() { Text = " 3 ", Selected = false },
                    new ListButtonModel() { Text = " 4 ", Selected = false },
                    new ListButtonModel() { Text = " 5 ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> BedroomSizeListButton
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Small ", Selected = false, SubText="Single Bed" },
                    new ListButtonModel() { Text = " Medium ", Selected = false, SubText="Double Bed" },
                    new ListButtonModel() { Text = " Large ", Selected = false, SubText="Queen Bed" },
                };
            }
        }

        public static List<ListButtonModel> BedroomFurnitureListButton
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " With bed ", Selected = false },
                    new ListButtonModel() { Text = " Without bed ", Selected = false },
                    new ListButtonModel() { Text = " With or Without Bed ", Selected = false },
                };
            }
        }

        public static List<ListButtonModel> BathroomFacilitiesListButton
        {
            get
            {
                return new List<ListButtonModel>()
                {
                    new ListButtonModel() { Text = " Shared ", Selected = false },
                    new ListButtonModel() { Text = " Own ", Selected = false },
                    new ListButtonModel() { Text = " Ensuite ", Selected = false },
                };
            }
        }

        public static dynamic UpdateButtonList(dynamic listOfStay, string btnText)
        {
            for (int i = 0; i < listOfStay.Count; i++)
            {
                var target = listOfStay[i];

                if (btnText == target.Text)
                    target.Selected = true;
                else
                    target.Selected = false;

                listOfStay[i] = target;
            }
            return listOfStay;
        }

        public static ObservableCollection<FeaturesModel> HomeFeatures
        {
            get
            {
                return new ObservableCollection<FeaturesModel>
                {
                    new FeaturesModel
                    {
                        Name = " Celling Fans ",
                        IsChecked =true
                    },
                    new FeaturesModel
                    {
                        Name = " Air-Conditing ",
                        IsChecked = false
                    },
                    new FeaturesModel
                    {
                        Name = " Living area heating ",
                        IsChecked = false
                    },
                    new FeaturesModel
                    {
                        Name = " Cabel or Satellite TV ",
                        IsChecked =  false
                    },
                     new FeaturesModel
                    {
                        Name = " Broadband Internet ",
                        IsChecked =true
                    },
                    new FeaturesModel
                    {
                        Name = " Dishwasher ",
                        IsChecked = false
                    },
                    new FeaturesModel
                    {
                        Name = " Clothes washer ",
                        IsChecked =  false
                    },
                    new FeaturesModel
                    {
                        Name = " Clothes dryer ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Study or office ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Storage room ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Balcony, patio or deck ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Courtyard, garden or yard ",
                        IsChecked =  false
                    },
                    new FeaturesModel
                    {
                        Name = " BBQ facilities ",
                        IsChecked = false
                    },
                    new FeaturesModel
                    {
                        Name = " City views ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Neighbourhood views ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Water views ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Electronic security ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Elevator/Lift ",
                        IsChecked =  false
                    },
                    new FeaturesModel
                    {
                        Name = " Swimming pool ",
                        IsChecked = false
                    },new FeaturesModel
                    {
                        Name = " Gym or fitness area ",
                        IsChecked =  false
                    },new FeaturesModel
                    {
                        Name = " Sauna ",
                        IsChecked =  false
                    },
                    new FeaturesModel
                    {
                        Name = " Spa or hot tub ",
                        IsChecked = false
                    }

                };
            }
        }

        public static ObservableCollection<FeaturesModel> BedroomFeatures
        {
            get
            {
                return new ObservableCollection<FeaturesModel>
                {
                    new FeaturesModel { Name = " Wardrobe or rack ", IsChecked =false },
                    new FeaturesModel { Name = " Built-in wardrobe ", IsChecked =true },
                    new FeaturesModel { Name = " Walk-in wardrobe ", IsChecked =false },
                    new FeaturesModel { Name = " Air-conditioner ", IsChecked =true },
                    new FeaturesModel { Name = " Ceiling fan ", IsChecked =false },
                    new FeaturesModel { Name = " Double glazed windows ", IsChecked =false },
                    new FeaturesModel { Name = " TV arial outlet ", IsChecked =false },
                    new FeaturesModel { Name = " Desk available ", IsChecked =false },
                    new FeaturesModel { Name = " Use of separate room ", IsChecked =false },
                    new FeaturesModel { Name = " Adjoining room ", IsChecked =false },
                    new FeaturesModel { Name = " Own outdoor area " , IsChecked =false },
                    new FeaturesModel { Name = " Good view or outlook ", IsChecked =false }
                };
            }
        }
    }
}
