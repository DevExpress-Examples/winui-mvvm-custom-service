<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/499442089/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1093379)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!--
A repository template for creating new examples.
-->

# WinUI MVVM UI Services - Create a Custom UI Service

Each service is a [UIServiceBase&lt;T&gt;](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.UIServiceBase-1?v=22.1) class descendant. The `T` parameter defines the associated control type. 

The [UIServiceBase&lt;T&gt;](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.UIServiceBase-1?v=22.1) class contains the [AssociatedObject](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Behavior.AssociatedObject?v=22.1) property. DevExpress MVVM Framework specifies this property when you add a service to the [Behaviors](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Interaction.Behaviors?v=22.1) collection. 

<!-- default file list -->

## Files to Look At

- [MainWindow.xaml](./CS/winui_mvvm_custom_service/winui_mvvm_custom_service/MainWindow.xaml)
- [MainWindow.xaml.cs](./CS/winui_mvvm_custom_service/winui_mvvm_custom_service/MainWindow.xaml.cs)
- [MainViewModel.cs](./CS/winui_mvvm_custom_service/winui_mvvm_custom_service/ViewModel.cs)
<!-- default file list end --> 

## Documentation

- [WinUI MVVM Framework](https://docs.devexpress.com/WinUI/102569/mvvm-framework?v=22.1)
- [WinUI MVVM UI Services](https://docs.devexpress.com/WinUI/402940/mvvm/services?v=22.1)

## More Examples

- [WinUI MVVM Service - Create a Custom Behavior](https://github.com/DevExpress-Examples/winui-mvvm-custom-behavior)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-mvvm-custom-service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-mvvm-custom-service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
