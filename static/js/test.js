function getUserList(){
    fetch(`http://143.244.180.75/users/api/`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            renderUsers(data);
        })
        .catch(err => {
            console.error(err);
        })
}
function renderUsers(data){
    return data.map(user => {
        renderUser(user);
    })
}
function renderUser(user){
    const root = document.getElementById('root');
    const div = document.createElement('div');
    const username = document.createElement('h2');
    username.innerText = user.username
    div.appendChild(username);
    root.appendChild(div);
}

getUserList()