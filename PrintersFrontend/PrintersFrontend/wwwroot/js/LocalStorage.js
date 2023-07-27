window.LocalStorageSet = function (name, value) {
    localStorage.setItem(name, value);
}

window.LocalStorageGet = function (name) {
    var key = localStorage.getItem(name);
    return key;
}

window.LocalStorageRemove = function (name) {
    localStorage.removeItem(name);
}