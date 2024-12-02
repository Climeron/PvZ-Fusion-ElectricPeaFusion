using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: MelonInfo(typeof(ElectricPeaFusion.Main), ElectricPeaFusion.AssemblyInfo.MODE_NAME, ElectricPeaFusion.AssemblyInfo.VERSION, ElectricPeaFusion.AssemblyInfo.AUTHOR)]

// Общие сведения об этой сборке предоставляются следующим набором
// набора атрибутов. Измените значения этих атрибутов для изменения сведений,
// связанные со сборкой.
[assembly: AssemblyTitle("ElectricPeaFusion")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ElectricPeaFusion")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Установка значения False для параметра ComVisible делает типы в этой сборке невидимыми
// для компонентов COM. Если необходимо обратиться к типу в этой сборке через
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("d2b15e2d-a58e-4df4-a1e6-157e61bb1ca3")]

// Сведения о версии сборки состоят из указанных ниже четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//      Номер сборки
//      Редакция
//
// Можно задать все значения или принять номера сборки и редакции по умолчанию 
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(ElectricPeaFusion.AssemblyInfo.VERSION)]
[assembly: AssemblyFileVersion(ElectricPeaFusion.AssemblyInfo.VERSION)]

namespace ElectricPeaFusion
{
    public static class AssemblyInfo
    {
        public const string MODE_NAME = nameof(ElectricPeaFusion);
        public const string VERSION = "214.0.0";
        public const string AUTHOR = "Climeron";
    }
}