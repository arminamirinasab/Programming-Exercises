// Generate Element Function
function generateElement(tag, attribute, value, ...childs) {
  const element = document.createElement(tag);
  element.setAttribute(attribute, value);

  childs.forEach((child) => {
    if (typeof child == "object") {
      element.appendChild(child);
    } else if (typeof child == "string") {
      element.innerText = child;
    }
  });

  mainTag.appendChild(element);
  return element;
}

// Create Cards In UI
function createCard(title, text, button) {
  generateElement("div", "class", "card",
    generateElement("div", "class", "content", 
     generateElement("h2", "class", "title", title), 
     generateElement("p", "class", "copy", text), 
     generateElement("button", "class", "btn", button)
   )
 );
}