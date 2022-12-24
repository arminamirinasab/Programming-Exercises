// Variables
let userAgent = navigator.userAgent;
let userBrowser = null;
// Check Browsers
if(userAgent.match(/edg/i)) {
    userBrowser = "edge";
} else if(userAgent.match(/firefox/i)) {
    userBrowser = "firefox";
} else if(userAgent.match(/opera/i)) {
userBrowser = "opera";
} else if (userAgent.match(/chrome/i)) {
    userBrowser = "chrome";
} else if (userAgent.match(/safari/)) {
    userBrowser = "safari";
}
// Change Opacity
if (document.querySelector(`.${userBrowser}`)) {
    document.querySelector(`.${userBrowser}`).style.opacity = "1";
}