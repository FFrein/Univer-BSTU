<template>
  <div :class="$style['menu']">
    <img src="../../../public/assets/Header/IMAGE.svg">
    <li :class="$style['menu-item']">Overview</li>
    <li :class="$style['menu-item']">Pages</li>
    <li :class="$style['menu-item']">Template</li>
  </div>
</template>

<script>

import styles from "@/components/Header/HeaderComponent.module.css";

export default {
  name: "Header_menu",
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>
