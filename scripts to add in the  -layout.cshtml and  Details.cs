 in the Details.cs
 
<!--Section of Scripts-->
@section  Scripts {
<script src="~/js/CustomScript.js"></script>
}

_Layout File 
 <div>
        @RenderBody()
    </div>
    @if (IsSectionDefined("Scripts"))
    {
        @RenderSection("Scripts", required: true)
    }
