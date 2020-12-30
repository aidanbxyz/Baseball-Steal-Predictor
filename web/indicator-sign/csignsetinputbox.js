function addtocssinputbox(numberkey) {
    var csignset = document.getElementById("csignset");
    csignset.value += '' + numberkey;
}

function removefromcssinputbox() {
    var csignset = document.getElementById("csignset");
    csignset.value = csignset.value.substring(0, csignset.value.length - 1);
}

function setcsssteal(cssstealstat) {
    var csswassteal = document.getElementById("csswassteal");
    if (cssstealstat) {
        csswassteal.value = 'true';
    } else if (!cssstealstat) {
        csswassteal.value = 'false';
    }
}