function strip(x: string | number){
    if(typeof x === 'number'){
        return x.toFixed(2);
    }
    return x.trim()
}

class MyResponse {
    header = 'header'
    result = 'result'
}

class MyError {
    header = 'E header'
    message = 'E message'
}

function handle(res: MyResponse | MyError){
    if(res instanceof MyResponse){
        return{
            info: res.header + res.result
        }
    }
    else{
        return {
            info: res.header + res.message
        }
    }
}

//=======================================

type AlertType = 'sucsess' | 'danger' | 'warning'

function setAlertType(type: AlertType){
    // ...
}

setAlertType('sucsess')

//setAlertType('default')