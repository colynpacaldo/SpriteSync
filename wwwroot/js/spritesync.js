let audioCtx;
const ctx = () => (audioCtx ??= new (window.AudioContext || window.webkitAudioContext)());

export function prefersReducedMotion() {
  return window.matchMedia('(prefers-reduced-motion: reduce)').matches;
}

function tone(type, f0, f1, start, dur, vol = 0.15) {
  const c = ctx();
  const o = c.createOscillator();
  const g = c.createGain();
  o.type = type;
  o.frequency.setValueAtTime(f0, c.currentTime + start);
  o.frequency.exponentialRampToValueAtTime(Math.max(1, f1), c.currentTime + start + dur);
  g.gain.setValueAtTime(vol, c.currentTime + start);
  g.gain.exponentialRampToValueAtTime(0.001, c.currentTime + start + dur);
  o.connect(g).connect(c.destination);
  o.start(c.currentTime + start);
  o.stop(c.currentTime + start + dur);
}

export function playPreviewTone(kind) {
  if (ctx().state === 'suspended') ctx().resume();
  if (kind === 'coin') { tone('square', 988, 988, 0, 0.08); tone('square', 1319, 1319, 0.08, 0.3); }
  else if (kind === 'laser') { tone('sawtooth', 1400, 150, 0, 0.3); }
  else { tone('square', 440, 440, 0, 0.25); }
}
