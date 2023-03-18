@inject NavigationManager Navigation
@inject SignOutSessionStateManager SignOutManager

<div class="user-info">
    <AuthorizeView>
        <Authorizing>
            <text>...</text>
        </Authorizing>
        <Authorized>
            <img src="img/user.svg" />
            <div>
                <a href="authentication/profile" class="username">@context.User.Identity.Name</a>
                <button class="btn btn-link sign-out" @onclick="BeginSignOut">Sign out</button>
            </div>
        </Authorized>
        <NotAuthorized>
            <a class="sign-in" href="authentication/register">Register</a>
            <a class="sign-in" href="authentication/login">Log in</a>
        </NotAuthorized>
    </AuthorizeView>
</div>

@code {
    async Task BeginSignOut()
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }
}
