@using (Html.BeginForm("SaveUser", "Home"))
{
    <p>
        User Name: <input type="text" name="UserName" />
    </p>

    <p>
        Password: <input type="password" name="Password" />
    </p>
    <input type="submit" value="Add User" />
    @Html.TextBoxFor(user => user.UserName)
    @Html.PasswordFor(user => user.Password)

}
