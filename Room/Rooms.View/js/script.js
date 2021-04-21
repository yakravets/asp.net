window.onload = mainPage;

const urlMainPage = "https://localhost:44399/Index";

function mainPage() {

    fetch(urlMainPage)
        .then(data => { return data.json() })
        .then(result => {
            let root = rootElement();
            root.innerHTML = "";
            let rows = "";

            result.forEach(element => {
                rows += `
            <div class="accordion-item">
                <h2 class="accordion-header" id="heading${element.id}">
                <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapse${element.id}" aria-expanded="true" aria-controls="collapse${element.id}">
                    ${element.name}
                </button>
                </h2>
                <div id="collapse${element.id}" class="accordion-collapse collapse ${element.id == 1 ? "show" : ""}" aria-labelledby="heading${element.id}" data-bs-parent="#accordionExample">
                <div class="accordion-body">
                    <div class="image">
                        <!-- <img src="https://via.placeholder.com/150" class="img-fluid" height: "400px"> -->
                        <img src="${element.pictureUrl}" class="img-fluid" width=400>
                    </div>
                    <ul class="list-group">
                        <li class="list-group-item"><strong><i class="bi bi-clock"></i> Duration:</strong> ${element.duration}</li>
                        <li class="list-group-item"><strong><i class="bi bi-people"></i> Minimum gamers:</strong> ${element.minCountGamers}</li>
                        <li class="list-group-item"><strong><i class="bi bi-calendar-date"></i> Min age:</strong> ${element.minAge}</li>
                        <li class="list-group-item"><strong><i class="bi bi-chat-right-text"></i> Rating:</strong> <span class="star-fill">${getRating(element.rating)}</span></li>                        
                        <button type="button" class="btn btn-success" onclick="detailPage(${element.id})">More <i class="bi bi-eye"></i></button>
                    </ul>
                </div>
                </div>
            </div>
            `;
            });

            root.innerHTML = `<div class="accordion" id="accordionExample">${rows}</div>`
        })
}

function detailPage(id) {
    let root = rootElement();

    const url = `https://localhost:44399/Room?id=${id}`

    fetch(url)
    .then(data=>{return data.json()})
    .then(result=>
        {
            root.innerHTML = `
                <div class="card">
                <div class="card-body">
                    <h5 class="card-title">${result.name}</h5>
                    <p class="card-text">${result.description}</p>
                    <div class="d-flex justify-content-center align-self-stretch"">
                        <ul class="list-group">
                            <li class="list-group-item"><strong><i class="bi bi-clock"></i> Duration:</strong> ${result.duration}</li>
                            <li class="list-group-item"><strong><i class="bi bi-people"></i> Minimum gamers:</strong> ${result.minCountGamers}</li>
                            <li class="list-group-item"><strong><i class="bi bi-calendar-date"></i> Min age:</strong> ${result.minAge}</li>
                            <li class="list-group-item"><strong><i class="bi bi-chat-right-text"></i> Rating:</strong> <span class="star-fill">${getRating(result.rating)}</span></li>                        
                            
                            <li class="list-group-item"><strong><i class="bi bi-bar-chart-line-fill"></i> Level of difficulty:</strong> ${result.levelOfDifficulty}</li>
                            <li class="list-group-item"><strong><i class="bi bi-bar-chart-line-fill"></i> level of fear:</strong> ${result.levelOfFear}</li>
                            <li class="list-group-item"><strong><i class="bi bi-building"></i> Company:</strong> ${result.company}</li>
                            <li class="list-group-item"><strong><i class="bi bi-compass"></i> Address:</strong> ${result.address}</li>
                            <li class="list-group-item"><strong><i class="bi bi-phone"></i> Phone:</strong> ${result.phoneNumber}</li>
                        </ul>
                        <img src="${result.pictureUrl}" class="card-img-bottom width" width="400">
                    </div>
                </div>
                </div>`;

        });
}

function rootElement() {
    return document.querySelector("#root");
}

function getRating(count) {
    let result = "";
    for (let i = 0; i < count; i++) {
        result += '<i class="bi bi-star-fill"></i>';
    }
    return result;
}

document.querySelector("#home").addEventListener("click", function(e){
    e.preventDefault();
    mainPage();
});