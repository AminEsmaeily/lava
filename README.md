# ![Lava](https://raw.githubusercontent.com/AminEsmaeily/lava/master/Lava.PlayGround/wwwroot/res/favicon.png) Lava!
##### A Blazor based component library
![Build and Test](https://github.com/AminEsmaeily/lava/workflows/Build%20and%20Test/badge.svg)
![Nuget](https://badgen.net/nuget/v/lava/latest?icon=nuget)

The Lava is a small set of UI components to be used in Blazor-based views. By default, this tool is dependent on [Font Awesome 5.*](https://fontawesome.com/) and [Bootstrap 4.*](https://getbootstrap.com/), but I will remove these dependencies in the next versions.

## Getting started
To get started with the **Lava**, install the following `Nuget` package in any Blazor project you want:
``` zsh
PM> Install-Package Lava
```

## Components

### LavaCollapsible
---
This component is a simple collapsible container that helps to show and hide parts of the application in UI.
#### Usage
Header with a simple text
``` HTML
<LavaCollapsible Header="Simple text goes here">
   <!-- Content of the LavaCollapsible -->         
</LavaCollapsible>
```
Header with template
``` HTML
<LavaCollapsible>
    <HeaderTemplate>
        <!-- The header template goes here -->
    </HeaderTemplate>
    <ChildContent>
        <!-- Content of the LavaCollapsible -->
    </ChildContent>
</LavaCollapsible>
```
#### Properties

 - Expanded

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property is for setting and getting the expanded state of the LavaCollapsible. This property is bindable and can be invoked whenever needed.

### LavaBaseInput
---
![Sample of the LavaSimpleInput](https://raw.githubusercontent.com/AminEsmaeily/lava/master/files/img1.png)

LavaBaseInput is a simple Text Input control that has some simple properties too. In the initial state, it doesn't have a style, because it is mainly for getting used in other components, but you can change its styles and graphical UI using CSS.
#### Usage
``` HTML
<LavaBaseInput/>
```
#### Properties

 - HasClearButton

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property determines the Clear Button to be shown or not. The default value of this property is `true`. 
- IsFocused

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shows the focus status of the component
 - IsPassword

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;To have a Password Box, this property should be set to `true`. The default value of this property is `false`.
 - Value

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property stores the text value of the control.

### LavaInput
---
![Sample of the LavaInput](https://raw.githubusercontent.com/AminEsmaeily/lava/master/files/img2.png)

**LavaInput** is the stylish version of the **LavaBaseInput** and comes with some additional features and properties. This component uses a floating label as its placeholder by default, but it can be hidden by the properties.
#### Usage
Simple usage
``` HTML
<LavaInput @bind-Value=@bindedVariable>
    <PlaceHolder>
        <!-- Content of the placeholder. It can be a simple text or composite UI -->
    </PlaceHolder>
</LavaInput>
```
Password
``` html
<LavaInput IsPassword="true" @bind-Value=@bindedVariable>
    <PlaceHolder>
        <!-- Content of the placeholder. It can be a simple text or composite UI -->
    </PlaceHolder>
</LavaInput>
```
Composite placeholder
``` html
<LavaInput @bind-Value=@textValue>
    <PlaceHolder>
        <div><img src="/res/chat.png" /> It can be very long placeholder content with a <a href="https://github.com/AminEsmaeily/lava">hyperlink</a></div>
    </PlaceHolder>
</LavaInput>
```
#### Properties
 - HasClearButton

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property determines the Clear Button to be shown or not. The default value of this property is `true`.
 - IsFocused
Shows the focus status of the component
 - IsPassword

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;To have a Password Box, this property should be set to `true`. The default value of this property is `false`.
 - PlaceHolder

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;A `RenderFragment` to represent the content as a floating placeholder.
 - Value

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property stores the text value of the control.

### LavaDatePicker
---
Default DatePicker
![enter image description here](https://raw.githubusercontent.com/AminEsmaeily/lava/master/files/img3.png)

Shamsi DatePicker
![enter image description here](https://raw.githubusercontent.com/AminEsmaeily/lava/master/files/img4.png)

**LavaDatePicker** is a multi-locale DatePicker component that can be used to represent 5 popular calendars. The following calendars are currently supported by **LavaDatePicker**:

 - Gregorian Calendar (Weekends and holidays of the selected country - default United States)
 - Persian / Shamsi Calendar (Weekends and holidays of Iran)
 - Hijri / UmAlQura Calendar (Weekends and holidays of the Saudi Arabia, Iraq, Qatar, Oman, United Arabic Emirates, Egypt, Morocco, and Tunisia besed on the selection)
 - Japanese Calendar (Weekends and holidays of the Japan - `Heisei era`)
 - Chinese Calendar (Weekends and holidays of the China - `Chinese Lunisolar Calendar`)

This component uses the [Nager.Date](https://github.com/nager/Nager.Date) to show the holidays and weekends of the countries. If the country code found in the above list, the **LavaDatePicker** will show the specified calendar, else it will use the `Gregorian Calendar` with the weekends and holidays of the selected country.
#### Usage
Simple usage
``` html
<LavaDatePicker>
    <PlaceHolder>
        <!-- Title of the DatePicker -->
    </PlaceHolder>
</LavaDatePicker>
```
With country code
``` html
<LavaDatePicker CountryCode="Nager.Date.CountryCode.TR">
    <PlaceHolder>
        Turkish Calendar
    </PlaceHolder>
</LavaDatePicker>
```
With icon and composite placeholder
``` html
<LavaDatePicker CountryCode="Nager.Date.CountryCode.IR">
	 <PlaceHolder>
	     <div><img src="/res/birthday.png" /> Birth date in Shamsi Calendar</div>
	 </PlaceHolder>
	 <Icon>
	     <img src="/res/calendar.png" width="24" height="24" />
	 </Icon>
</LavaDatePicker>
```
#### Properties

 - CloseWhenSelected

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;By setting this propertes' value to `false` the DropDown stays open when the use selects a date. default `true`.
 - CountryCode

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property is to determine the country to handle the calendar type, weekends, and holidays. default `US`.
 - Icon

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;A `RenderFragment` to demonstrate the icon of the dropdown button. The best size of the icon is 24px × 24px. default `null`.
 - IsDropdownOpen

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;A bindable property to control and check the dropdown state. default `false`.
 - IsFocused
Shows the focus status of the component. default `false`.
 - PlaceHolder

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;A `RenderFragment` to demonstrate the placeholder of the DatePicker. default `null`.
 - SelectedDate

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This property holds the user selected value. default `null`.
 - Value

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The string representation of the selected date. default `empty string`.
