const apiurl = "https://pokeapi.co/api/v2/pokemon/";
let inputName = document.getElementById("inputName");
let result = document.getElementById("result");
let data;

async function search() {
    let name = inputName.value;
    try {
        let response = await fetch(apiurl + name);
        data = await response.json();
        display();
    } catch (error) {
        console.error(error);
    }
}

async function goToNext() {
    try {
        let response = await fetch(apiurl + (data.id + 1));
        data = await response.json();
        display();
    } catch (error) {
        console.error(error);
    }
}

async function goToPrev() {
    try {
        let response = await fetch(apiurl + (data.id - 1));
        data = await response.json();
        display();
    } catch (error) {
        console.error(error);
    }
}

function display() {
    result.innerHTML = "";
    console.log(data);
    result.innerHTML += `<h2>${data.name}</h2>`;
    result.innerHTML += `<img src="${data.sprites.front_default}" alt="${data.name}"/>`;
    result.innerHTML += `<p>Numéro d'identification : ${data.id}</p>`
    result.innerHTML += `<p>Poids : ${data.weight} kg</p>`;
    result.innerHTML += `<p>Taille : ${data.height} m</p>`;
    result.innerHTML += `<p>Types :</p><ul>`
    data.types.forEach(t => {
        result.innerHTML += `<li>${t.type.name}</li>`;
    })
    result.innerHTML += `</ul>`;
    result.innerHTML += `<p>Capacités :</p><ul>`
    data.abilities.forEach(a => {
        result.innerHTML += `<li>${a.ability.name}</li>`;
    })
    result.innerHTML += `</ul>`;
}