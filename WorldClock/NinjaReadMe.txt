
----------------------------------------------------------------------------------------------------
20 六月 16 22:36 Add Projects
----------------------------------------------------------------------------------------------------
WorldClock.Core project successfully added. (template NinjaCoder.Core.zip)
WorldClock.Droid project successfully added. (template NinjaCoder.Droid.zip)
WorldClock.iOS project successfully added. (template NinjaCoder.iOS.zip)
WorldClock.WindowsPhone project successfully added. (template NinjaCoder.WindowsPhone.zip)
WorldClock.WindowsUniversal project successfully added. (template NinjaCoder.WindowsUniversal.zip)

----------------------------------------------------------------------------------------------------
Options
----------------------------------------------------------------------------------------------------
MvvmCross framework selected.
NUnit testing framework selected.
Moq mocking framework selected.
iOS View Type Xib selected.

MainViewModel.cs added to WorldClock.Core project (template=MvxSampleDataViewModel.t4)
MainView.cs added to WorldClock.iOS project (template=SampleData\Xib\View.t4)
MainView.cs added to WorldClock.Droid project (template=SampleDataView.t4)
MainView.xaml added to WorldClock.WindowsPhone project (template=SampleDataView.t4)
MainView.xaml added to WorldClock.WindowsUniversal project (template=SampleDataView.t4)

----------------------------------------------------------------------------------------------------
Nuget Commands
----------------------------------------------------------------------------------------------------

Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.Core 
Install-Package Scorchio.NinjaCoder.MvvmCross.Core -FileConflictAction Overwrite -ProjectName WorldClock.Core 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.Droid 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction ignore -ProjectName WorldClock.Droid 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.iOS 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction ignore -ProjectName WorldClock.iOS 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.WindowsPhone 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.WindowsPhone 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName WorldClock.WindowsUniversal 
Install-Package Scorchio.NinjaCoder.MvvmHelper.Core -FileConflictAction ignore -ProjectName WorldClock.Core
Install-Package MvvmCross.Plugin.File -FileConflictAction ignore -ProjectName WorldClock.Core
Install-Package MvvmCross.Plugin.File -FileConflictAction ignore -ProjectName WorldClock.iOS
Install-Package MvvmCross.Plugin.File -FileConflictAction ignore -ProjectName WorldClock.Droid
Install-Package MvvmCross.Plugin.File -FileConflictAction ignore -ProjectName WorldClock.WindowsPhone
Install-Package MvvmCross.Plugin.File -FileConflictAction ignore -ProjectName WorldClock.WindowsUniversal
Install-Package MvvmCross.Plugin.Json -FileConflictAction ignore -ProjectName WorldClock.Core
Install-Package MvvmCross.Plugin.Json -FileConflictAction ignore -ProjectName WorldClock.iOS
Install-Package MvvmCross.Plugin.Json -FileConflictAction ignore -ProjectName WorldClock.Droid
Install-Package MvvmCross.Plugin.Json -FileConflictAction ignore -ProjectName WorldClock.WindowsPhone
Install-Package MvvmCross.Plugin.Json -FileConflictAction ignore -ProjectName WorldClock.WindowsUniversal
Install-Package MvvmCross.Plugin.MethodBinding -FileConflictAction ignore -ProjectName WorldClock.Core
Install-Package MvvmCross.Plugin.MethodBinding -FileConflictAction ignore -ProjectName WorldClock.iOS
Install-Package MvvmCross.Plugin.MethodBinding -FileConflictAction ignore -ProjectName WorldClock.Droid
Install-Package MvvmCross.Plugin.MethodBinding -FileConflictAction ignore -ProjectName WorldClock.WindowsPhone
Install-Package MvvmCross.Plugin.MethodBinding -FileConflictAction ignore -ProjectName WorldClock.WindowsUniversal


----------------------------------------------------------------------------------------------------
Ninja Coder for MvvmCross and Xamarin Forms v4.2.0
----------------------------------------------------------------------------------------------------

All feedback welcome, please get in touch via twitter.

Issues Log http://github.com/asudbury/NinjaCoderForMvvmCross/issues

Thanks

@asudbury
