// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function changeTheme(themeUrl) {
    $('#mainWindow').css('background-image', "url('" + themeUrl + "')");
    $('#openSidebarMenu').click();

    $('#ChangeShowPanelIframe').attr('src', '/HidePanelPage?themeUrl=' + themeUrl);
    $('#ChangeShowPanelIframe').reload();
}
function changeStyle(objid, type) {
    $('#' + objid).attr('class', type);
}
function SwitchPanel() {
    var showPanel = $('#hidden_ShowPanel').val();
    //$('#returnToIndex').toggle();
    if (showPanel.indexOf("none") != -1) {  // "display:none;"
        $('#panelMenu').show();
        $('#hidden_ShowPanel').val('block');
        $('#ChangeShowPanelIframe').attr('src', '/HidePanelPage?showPanel=block');
        $('#ChangeShowPanelIframe').reload();
    } else {
        $('#panelMenu').hide();
        $('#hidden_ShowPanel').val('none');
        $('#ChangeShowPanelIframe').attr('src', '/HidePanelPage?showPanel=none');
        $('#ChangeShowPanelIframe').reload();
    }
}
function Init() {
    $('#ChangeShowPanelIframe').attr('src', '');
    //$('#ChangeShowPanelIframe').reload();
}
onload = Init;