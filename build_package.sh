#!/usr/bin/env bash
set -eu
BASE_DIR=$(realpath "$(dirname "$0")")
PKG_DIR=$BASE_DIR/Assets/CupAndSaucer
OUT_DIR=$BASE_DIR/out
VERSION=$(jq -r .version $PKG_DIR/package.json)
OUT_FILE=$OUT_DIR/ms.sora.cup-and-saucer-$VERSION.zip
mkdir -p $OUT_DIR
cd $BASE_DIR
cp LICENSE.md README.md $PKG_DIR
cd $PKG_DIR
rm -f $OUT_FILE
7z a -r $OUT_FILE ./*
