<template>
  <div :class="$style['footer']">

  <Footer_Up/>

  <footer_down/>

  </div>
</template>

<script>

import Footer_Up from "@/components/Footer/Footer_Up";
import footer_down from "@/components/Footer/footer_down";
import styles from "@/components/Footer/FooterComponent.module.css";

export default {
  name: "TheFooter",
  components: {Footer_Up, footer_down},
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>

<style scoped>

</style>