<template>
  <div :class="$style['footer_down']">
    <img src="../../../public/assets/Header/IMAGE.svg" alt="">
    |
    <p :class="$style['padd']">| © Template by</p>
    <a href="" :class="$style['padd']">Flowbase</a>
    <p :class="$style['padd']">- Powered by</p>
    <a href="" :class="$style['padd']">Webflow</a>

    <p>Overview</p>
    <p>Pages</p>

  </div>
</template>

<script>
import styles from "@/components/Footer/FooterComponent.module.css";

export default {
  name: "footer_down",
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>
