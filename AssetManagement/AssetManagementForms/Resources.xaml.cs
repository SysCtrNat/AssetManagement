using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;
using System.Globalization;

namespace AssetManagementForms
{
    public partial class Resources : ResourceDictionary
    {
        public static Guid guidAssetStatusTypeEnumRoot = new Guid("df83475d-d6d1-7236-fc6d-ec8fe52022b0");
        public static Guid guidAssetManufacturerTypeEnumRoot = new Guid("6e131742-a95b-6143-05c8-ee0f1aabae06");
        public static Guid guidComputerAssetModelTypeEnumRoot = new Guid("457cb61d-0c0c-7229-62ef-7b343f7b7941");
        public static Guid guidPeripheralAssetModelTypeEnumRoot = new Guid("f210124d-d48e-3731-bd6e-262a9e6f643b");
        public static Guid guidServerInfrastructureAssetModelTypeEnumRoot = new Guid("831c64df-ac7a-72d5-7ea2-427318c47f6b");
        public static Guid guidNetworkInfrastructureAssetModelTypeEnumRoot = new Guid("6ab155be-3976-8ec3-13a7-933b18330c68");
        public static Guid guidComputerCategoryTypeEnumRoot = new Guid("7033f960-9392-e084-d4f9-fe2fbdae3606");
        public static Guid guidComputerTypeTypeEnumRoot = new Guid("095cda58-36bc-84ad-dadb-ee10a0112fb4");
        public static Guid guidPeripheralTypeTypeEnumRoot = new Guid("6e8fce3b-6695-4d2d-375c-8d0f703f3e64");
        public static Guid guidServerInfrastructureTypeTypeEnumRoot = new Guid("2caf5c22-9525-194d-62bc-b042bea8c23f");
        public static Guid guidNetworkInfrastructureTypeTypeEnumRoot = new Guid("b9e03ca5-f1ed-743b-f25f-3a9cc02cd065");
        public static Guid guidRegionTypeEnumRoot = new Guid("06076434-a98c-4ecd-ee34-d826ea9439a1");
        public static Guid guidCountryTypeEnumRoot = new Guid("c94c8568-8cc8-2f32-ec3a-8b8b04cc9848");
        public static Guid guidSiteTypeEnumRoot = new Guid("9d07bd6a-9e08-439e-486c-4ba4e7f88b30");
        public static Guid guidSuppliersTypeEnumRoot = new Guid("9f92bf02-c838-cb22-bf02-7e6b3cd43e9f");
        public static Guid guidDepartmentTypeEnumRoot = new Guid("e41e818b-ff74-119f-f256-f558862cb154");
    }

    public class SelectNonNullValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            foreach (object val in values)
            {
                if (val == null || val == DependencyProperty.UnsetValue)
                    continue;
                else
                    // cast to string, in other case field will not be casted in UI
                    if (targetType == typeof(String))
                        return val.ToString();
                    else
                        return val;
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }

        public static SelectNonNullValueConverter Default
        { get { return new SelectNonNullValueConverter(); } }
    }

}
