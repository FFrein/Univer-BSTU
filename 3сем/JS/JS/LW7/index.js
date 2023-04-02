const dart = document.querySelector('.Darts');
let StartPos_X = -100;
let StartPos_Y = -100;
let x = StartPos_X;
let y = StartPos_Y;
let wasClicked = false;

dart.onmousedown = function(event) {
    if (wasClicked) {
        document.body.onmousemove = null;                              // Отключение движения стрелы
        document.body.onclick = () => animate(x, y, StartPos_X, StartPos_Y); 
        return;
    }
    dart.style.zIndex = '1000';                                        
    wasClicked = wasClicked ? false : true;                            // Переключение состояния стрелы

    document.body.onmousemove = function(event) {
        if (StartPos_X === -100 && StartPos_Y === -100) {                      // Первое нажатие
            StartPos_X = event.clientX - 5;                              
            dart.style.left = `${StartPos_X}px`;                         
            StartPos_Y = event.clientY - 20;
            dart.style.top = `${StartPos_Y}px`;
            dart.style.cursor = "none";
            document.body.append(dart);
        }
        if (Math.abs(StartPos_X - event.clientX) < 300) {
            x = event.clientX - 5;
        }
        if (Math.abs(StartPos_Y - event.clientY) < 100) { 
            y = event.clientY - 5;
        }
        dart.style.left = `${x}px`;
        dart.style.top = `${y}px`;
    };
};

function animate(x, y, StartPos_X, StartPos_Y) {
    let dx = (StartPos_X - x);
    let dy = (StartPos_Y - y);
    let tg = dy / dx;
    StartPos_X = dx < 0 ? StartPos_X - 3 * Math.abs(dx) : StartPos_X + 3 * Math.abs(dx);
    StartPos_Y = dy < 0 ? StartPos_Y - 3 * Math.abs(tg * dx) : StartPos_Y + 3 * Math.abs(tg * dx);
    dart.style.left = `${StartPos_X}px`;    //x
    dart.style.top = `${StartPos_Y}px`;     //y

}