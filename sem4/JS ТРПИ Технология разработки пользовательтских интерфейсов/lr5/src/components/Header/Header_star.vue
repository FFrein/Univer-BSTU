<template>
  <div :class="$style['star']">
    <img src="../../../public/assets/Header/Vector.svg">
    Tell your customers of something important with this banner!
  </div>
</template>

<script>
import styles from "@/components/Header/HeaderComponent.module.css";

export default {
  name: "Header_star",
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>
