function submitting(e) {
  e.preventDefault();
  let count = 0;
  document.getElementById("nots").innerHTML = "";
  if (!/[A-Za-z\ ]{7,20}/.test(document.getElementsByName("fname")[0].value)) {
    var par = document.createElement("p");
    par.innerHTML = "- name must be in range between (7-20) characters";
    document.getElementById("nots").appendChild(par);
  } else count++;
  if (
    !/[A-Za-z0-9]{8,15}/.test(document.getElementsByName("password")[0].value)
  ) {
    var par = document.createElement("p");
    par.innerHTML =
      "- Password must be in range between (8-15) alphanumeric characters";
    document.getElementById("nots").appendChild(par);
  } else count++;
  if (
    !/^([A-Za-z0-9\.]{3,16})@[A-Za-z]{3,10}(\.[A-Za-z]{2,5})$/.test(
      document.getElementsByName("email")[0].value
    )
  ) {
    var par = document.createElement("p");
    par.innerHTML = "- Email must be in this form bbbbbb@eeeeeee.ccccc";
    document.getElementById("nots").appendChild(par);
  } else count++;
  if (count == 3) location.assign("/home.html");
}
