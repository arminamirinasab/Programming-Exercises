// Variable
const button = document.querySelector('.cta')
// Event
button.addEventListener('click', () => {

    if(navigator.getBattery) {
        navigator.getBattery().then(res => {
            console.log(res);
            // Button Text With Some Condition
            let status = `${res.charging ? "Charging:" : ""} ${res.level * 100}% - ${res.charging ? Math.floor(res.chargingTime / 60) + " Minute Until Fully Charged": Math.floor(res.dischargingTime / 60) + " Minute Remaining"}`;
            button.innerHTML = status;

            // Change Battery Level
            res.addEventListener("levelchange" , () => {
                // Update Level In Button
                button.innerHTML = status;
            });

            // Connect Or Disconnect Charger
            res.addEventListener("chargingchange" , () => {
                // Change Button Text
                button.innerHTML = "Charger Connected / Disconnected";
            });
        })
    }
});