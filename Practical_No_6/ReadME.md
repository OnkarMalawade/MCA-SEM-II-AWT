# Asp.Net MVC
<img src = "https://github.com/OnkarMalawade/MCA-SEM-II-AWT/blob/main/Practical_No_6/Screenshot%202024-05-14%20121314.png" alt = "MVC Select"/>
<img src = "https://github.com/OnkarMalawade/MCA-SEM-II-AWT/blob/main/Practical_No_6/Screenshot%202024-05-14%20122341.png" alt = "MVC Select Controller"/>
Never Delete Handler "Controller"

<img src="https://github.com/OnkarMalawade/MCA-SEM-II-AWT/blob/main/Practical_No_6/Screenshot%202024-05-14%20122351.png" alt="Selection MVC">

<p>
MVC=Model View Controller
1)MVC Patterns=>
>Models=>Represent Data that user work with.
>View=>Page render some part of model as a UI using Language
>Controller=>which process incoming requests , perform operations on the model, and select views to render to the user

2)MVC Pattern   
    http	
Req----->Control<->Model
	    |
	    |presentation model
	    |
	    view->response
Creating Project
1)Create an Empty Web Application Project
2)Checked MVC option from Add Options and References
3)For Controller=>Add controller(Empty) ++ActionResult(ViewResult/JsonResult/FileStreamResult

4)Inside View Method brackets {right Click->Add View->rename it and uncheck "Use a layout page"}
5)Goto HomeController add greet function

6)Add model Class(Models File->Add->Class)

HtmlHelper Methods=>
Check Box=>Html.CheckBox("CheckBoxNM",false)

Html.field=>Html.Hidden("nm","val")

Radio button=>Html.RadioButton("nm","val",true)

Strongly Coupled Input: 
CheckBox => Html.CheckBoxFor(x => x.isApproved)

When user is post data set method call , user is get data then get data is Called


</p>

## Strongly Typed Input Helper Method
<p>
Lambda expression is used,
  Check Box=>Html.CheckBox("CheckBoxNM" => isApproved())
</p>
