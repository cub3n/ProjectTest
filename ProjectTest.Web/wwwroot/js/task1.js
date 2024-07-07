function onBoxClicked(event) {
  const selected = event.target;
  const children = document.querySelectorAll(".child");
  children.forEach((c) => c.classList.remove("checked"));

  selected.classList.toggle("checked");
}
