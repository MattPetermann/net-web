$(function(){
    //Build nav bar
    $('#nav').html(
        '<nav class="navbar navbar-expand-lg navbar-dark bg-dark">' +
        '   <button class="navbar-toggler" type="button" data-toggle="collapse" ' +
        '       data-target="#navbarToggler">' +
        '       <span class="navbar-toggler-icon"></span>' +
        '    </button>' +
        '    <div class="collapse navbar-collapse" id="navbarToggler">' +
        '        <ul class="navbar-nav">' +
        '            <li class="nav-item">' +
        '                <a class="nav-link" href="index.html"><i class="fas fa-home"></i> Home</a>' +
        '            </li>' +
        '            <li class="nav-item dropdown">' +
        '                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown">' +
        '                    <i class="fas fa-book"></i> Lessons' +
        '                </a>' +
        '                <div class="dropdown-menu bg-dark">' +
        '                    <a class="dropdown-item bg-dark" href="happyBirthday.html">' +
        '                       <i class="fas fa-bookmark"></i> Happy Birthday</a>' +
        '                </div>' +
        '            </li>' +
        '        </ul>' +
        '    </div>' +
        '</nav>');

    //Build jumbotron
    $('#jumbotron').html(
        '<div class="jumbotron">' +
        '   <h1>MVC Demo</h1>' +
        '   <p>Looking for a discount code? Click' +
        '       <a href="#" data-toggle="popover" data-content="MATT">here ' +
        '       <i class="fas fa-location-arrow"></i></a>.' +
        '   </p>' +
        '</div>'
    );

    //Add popover functionality
    $('[data-toggle="popover"]').popover();
});