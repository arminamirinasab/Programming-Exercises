import React, { Component } from "react";
import CourseCard from "./components/courseCard";
import "./style.css";

class App extends Component {
  state = {};
  render() {
    return (
      <>
        <section className="author-archive">
          <div className="container">
            <h1>Some of Tuts+ Tutorials</h1>
            <input type="radio" id="All" name="categories" defaultValue="All" defaultChecked />
            <input type="radio" id="CSS" name="categories" defaultValue="CSS" />
            <input type="radio" id="JavaScript" name="categories" defaultValue="JavaScript" />
            <input type="radio" id="jQuery" name="categories" defaultValue="jQuery" />
            <input type="radio" id="WordPress" name="categories" defaultValue="WordPress" />
            <input type="radio" id="Slider" name="categories" defaultValue="Slider" />
            <input type="radio" id="fullPage.js" name="categories" defaultValue="fullPage.js" />
            <ol className="filters">
              <li>
                <label htmlFor="All">All</label>
              </li>
              <li>
                <label htmlFor="CSS">CSS</label>
              </li>
              <li>
                <label htmlFor="JavaScript">JavaScript</label>
              </li>
              <li>
                <label htmlFor="jQuery">jQuery</label>
              </li>
              <li>
                <label htmlFor="WordPress">WordPress</label>
              </li>
              <li>
                <label htmlFor="Slider">Slider</label>
              </li>
              <li>
                <label htmlFor="fullPage.js">fullPage.js</label>
              </li>
            </ol>

            <ol className="posts">
              <CourseCard category={["CSS", "JavaScript"]} title="Quick Tip: Create a Very Simple Parallax Effect With CSS & JavaScript" link="https://webdesign.tutsplus.com/tutorials/quick-tip-how-to-build-a-dead-simple-parallax-effect-with-css-javascript--cms-33061?_ga=2.146015156.1249101154.1555312171-2126893531.1553152868" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/parallax-pre.jpg" />
              <CourseCard category={["CSS", "JavaScript"]} title="How to Build a Static Portfolio Page With CSS & JavaScript" link="https://webdesign.tutsplus.com/tutorials/how-to-build-a-portfolio-page-with-css-javascript--cms-32933?_ga=2.268974834.267848227.1555345574-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/chart-pre.png" />
              <CourseCard category={["JavaScript", "WordPress"]} title="Dropdown Navigation: How to Maintain the Selected Option On WordPress" link="https://webdesign.tutsplus.com/tutorials/dropdown-navigation-how-to-maintain-the-selected-option-on-page-load-on-a-wordpress-site--cms-32211?_ga=2.3551667.267848227.1555345574-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/pre-wp.png" />
              <CourseCard category={["CSS", "JavaScript"]} title="Dropdown Navigation: How to Maintain the Selected Option On WordPress" link="https://webdesign.tutsplus.com/tutorials/dropdown-navigation-how-to-maintain-the-selected-option-on-page-load-on-a-wordpress-site--cms-32211?_ga=2.3551667.267848227.1555345574-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/load-pre.png" />
              <CourseCard category={["CSS"]} title="Enhance the Way a Web Page Loads With CSS Animations" link="https://webdesign.tutsplus.com/tutorials/quick-tip-how-to-enhance-a-page-with-css-animations--cms-32100?_ga=2.3551667.267848227.1555345574-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/animations-pre.png" />
              <CourseCard category={["CSS"]} title="How to Build a Full-Screen Responsive Page With Flexbox" link="https://webdesign.tutsplus.com/tutorials/quick-tip-how-to-enhance-a-page-with-css-animations--cms-32100?_ga=2.3551667.267848227.1555345574-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/flex-pre.png" />
              <CourseCard category={["fullPage.js"]} title="How to Create an Animated Spirit Day Presentation With fullPage.js" link="https://webdesign.tutsplus.com/tutorials/how-to-create-an-animated-spirit-day-presentation-with-fullpagejs--cms-32005?_ga=2.171060384.1249101154.1555312171-2126893531.1553152868" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/spirit-pre.jpg" />
              <CourseCard category={["CSS", "JavaScript"]} title="Quick Tip: How to Manipulate the Cursor Appearance With CSS" link="https://webdesign.tutsplus.com/tutorials/quick-tip-how-to-manipulate-cursor-appearance-with-css--cms-31825?_ga=2.149104566.1249101154.1555312171-2126893531.1553152868" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/cursor-pre.jpg" />
              <CourseCard category={["jQuery", "CSS", "Slider"]} title="How to Build a Full-Screen Responsive Carousel Slider With Owl.js" link="https://webdesign.tutsplus.com/tutorials/how-to-build-a-full-screen-responsive-carousel-slider-with-owljs--cms-31771?_ga=2.214527703.1129106392.1555690352-242901505.1471790948" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/pre-oo.png" />
              <CourseCard category={["jQuery", "CSS", "Slider"]} link="https://webdesign.tutsplus.com/tutorials/how-to-build-an-attractive-responsive-image-gallery-with-slickjs--cms-31355?_ga=2.245039813.1129106392.1555690352-242901505.1471790948" title="How to Build an Attractive Responsive Image Gallery With slick.js" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/slick-pre.png" />
              <CourseCard category={["CSS", "JavaScript"]} link="https://webdesign.tutsplus.com/tutorials/a-simple-javascript-technique-for-filling-star-ratings--cms-29450?_ga=2.239800003.1129106392.1555690352-242901505.1471790948" title="A Simple JavaScript Technique for Filling Star Ratings" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/stars-pre.png" />
              <CourseCard category={["jQuery", "fullPage.js"]} link="https://webdesign.tutsplus.com/tutorials/quick-tip-scroll-animations-with-fullpagejs-and-animatecss--cms-25235?_ga=2.245041733.1129106392.1555690352-242901505.1471790948" title="Quick Tip: Scroll Animations With fullPage.js and Animate.css" image="https://s3-us-west-2.amazonaws.com/s.cdpn.io/162656/scroll-preview.jpg" />
            </ol>
          </div>
        </section>

        <footer>
          <div className="container">
            <small>
              <span>❤</span> Special thanks to
              <a href="http://github.com/arminamirinasab/" target="_blank">
                Armin Amiri Nasab
              </a>
            </small>
          </div>
        </footer>
      </>
    );
  }
}

export default App;
