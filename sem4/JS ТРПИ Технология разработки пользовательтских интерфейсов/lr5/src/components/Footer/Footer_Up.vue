<template>
  <div :class="$style['footer_up']">
    <div>
      <h1>
        Build a beautiful
        product with Align
      </h1>
      <p>
        Align contains all the pages and sections needed to create beautiful digital products with ease.
      </p>
    </div>
    <div :class="$style['elements']" v-for="elem in elems" v-bind:key="elem">
      <div>
        <h5>
          {{elem.name}}
        </h5>
        <div :class="$style['item']" v-for="item in elem.items" v-bind:key="item">
          <a href="{{item.src}}}"
             @mousemove="onMousemove"
             :style="{ color: `hsl(${x}, 90%, 60%)` }"
             :class="$style['movearea']"
          >{{item.name}}</a>
        </div>
      </div>

    </div>
  </div>
</template>

<script>
import styles from "@/components/Footer/FooterComponent.module.css";

export default {
  name: "Footer_Up",
  data() {
    return {
      x: 0,
      elems:[
        {name: "Overview", items:[{src:"", name:"Overvier"},{src:"", name:"Home 1"},{src:"", name:"Home 2"},{src:"", name:"Home 3"},{src:"", name:"Pricing 1"}, {src:"", name:"Pricing 2"}]},
        {name: "Pages", items:[{src:"", name:"About 1"},{src:"", name:"About 2"},{src:"", name:"About 3"},{src:"", name:"Blog 1"},{src:"", name:"Blog 2"},{src:"", name:"Blog Post"},{src:"", name:"Team Member"},{src:"", name:"404"}, {src:"", name:"Password"}]},
        {name: "Pages", items:[{src:"", name:"Concat 1"},{src:"", name:"Concat 2"},{src:"", name:"Concat 3"},{src:"", name:"Customer Stories"},{src:"", name:"Customer Story"},{src:"", name:"Login"},{src:"", name:"Register"},{src:"", name:"Style Guide"},{src:"", name:"Changelog"}, {src:"", name:"Licence"}]},
      ],
    }
  },
  methods: {
    onMousemove(e) {
      this.x = e.clientX
    }
  },
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>
