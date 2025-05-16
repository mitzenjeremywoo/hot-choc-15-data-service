
To create record use 
    -----------------------------------------------------
mutation { 
    addUser(user: {
      id : 3, name: "jessie", username: "jessie"
    }) 
    {
      id
    }
}


To support data time 

mutation { 
    addUser(user: {
      id : 3, 
      name: "jessie", username: "jessie", birthday: "1990-01-01T00:00:00Z"
    }) {
      id
    }
}