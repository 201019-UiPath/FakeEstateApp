function GetAllFeatures()
{
    fetch('https://localhost:44341/Feature/GetAllFeatures') //fetch JSON list of houses
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#features tbody tr').forEach(element => element.remove()); //clear table
        let table = document.querySelector('#features tbody'); //gets table element
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); //adds new row at the end
            let cell0 = row.insertCell(0);
            cell0.innerHTML = result[i].featureId;

            let cell1 = row.insertCell(1);
            cell1.innerHTML = result[i].description;

            let cell2 = row.insertCell(2);
            cell2.innerHTML = result[i].fee;
        }
    });
}


function AddFeature()
{
    let feature = {};
    feature.description = document.querySelector('#description').value;
    feature.fee = parseInt(document.querySelector('#fee').value);

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("New Feature has been added!");
            document.querySelector('#description').value= '';
            document.querySelector('#fee').value= '';
        }
    };
    xhr.open("POST", 'https://localhost:44341/Feature/AddFeature', false);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(feature));
}

function AddHouseFeature()
{
    let housefeature = {};
    housefeature.houseId = parseInt(document.querySelector('#houseid').value);
    housefeature.featureId = parseInt(document.querySelector('#featureid').value);

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("Feature has been added to house!");
            document.querySelector('#houseid').value= '';
            document.querySelector('#featureid').value= '';
        }
    };
    xhr.open("POST", 'https://localhost:44341/HouseFeature/AddHouseFeature', false);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(housefeature));
}