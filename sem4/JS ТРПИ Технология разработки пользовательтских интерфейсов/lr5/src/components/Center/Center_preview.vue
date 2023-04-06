<template>
  <div :class="$style['preview']">
    <h5>ALIGN UI KIT FOR WEBFLOW</h5>
    <h1>
      Teams build better
      <br>
      products with<br>
      Align UI
    </h1>
    <img v-bind="under_img"/>
    <img v-bind="big_img"/>
  </div>
</template>

<script>

import styles from "@/components/Center/CenterComponent.module.css";

export default {
  name: "Center_preview",
  data() {
    return {
      under_img: {
        id: "UnderImg",
        src: "assets/Center/Vector.png",
      },
      big_img:{
        src: "assets/Center/IMAGE.png"
      },
    }
  },
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>
