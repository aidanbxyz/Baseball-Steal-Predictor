document.addEventListener("keydown", (event) => {
    var key = event.keyCode;
    if (key == 49 || key == 97) {
        console.log('1');
        addtocssinputbox(1);
    } else if (key == 50 || key == 98) {
        console.log('2');
        addtocssinputbox(2);
    } else if (key == 51 || key == 99) {
        console.log('3');
        addtocssinputbox(3);
    } else if (key == 52 || key == 100) {
        console.log('4');
        addtocssinputbox(4);
    } else if (key == 53 || key == 101) {
        console.log('5');
        addtocssinputbox(5);
    } else if (key == 54 || key == 102) {
        console.log('6');
        addtocssinputbox(6);
    } else if (key == 55 || key == 103) {
        console.log('7');
        addtocssinputbox(7);
    } else if (key == 56 || key == 104) {
        console.log('8');
        addtocssinputbox(8);
    } else if (key == 57 || key == 105) {
        console.log('9');
        addtocssinputbox(9);
    } else if (key == 48 || key == 96) {
        console.log('0');
        addtocssinputbox(0);
    } else if (key == 8) {
        console.log('backspace');
        removefromcssinputbox();
    } else if (key == 13) {
        console.log('enter');
        runmainalg();
    } else if (key == 84) {
        console.log('true');
        setcsssteal(true);
    } else if (key == 70) {
        console.log('false');
        setcsssteal(false);
    } else if (key == 9) {
        console.log('tab register');
        setbuttonnames();
    }
});