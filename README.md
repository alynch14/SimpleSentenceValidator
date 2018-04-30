# SimpleSentenceValidator

Quick Overview:

This program is a SIMPLIFIED re-implementation – in a functional language – of a subset of the “syntax analyzer” from Program I. The grammar will be the same, but there are some minor changes to make it a bit simpler:

1. You should just prompt the user for an input sentence (no reading from a file).

· Enter Sentence: user enters sentence here…

2. You assume the input is completely space delimited.

· This allows the input to be added to a simple List but splitting it on spaces.

· Pretty much every language has a built-in (standard library) function for this which you may use.

3. The output is in the is simply an indicator of whether or not the input sentence ins syntactically valid.

4. (NOTE: Since a choice of languages is given, the “rules” must remain flexible, hence the use of where applicable in several of the rules below.)

* Must use “High Order Functions” where applicable.

* The only permitted “looping (iterative) constructs” are:

o Recursion / Tail-Recursion

o Streams, Maps, Folds

o Sequences

o In most purely functional languages, these would be your only options

* Must use “strong” and proper datatypes where applicable

o For example, much like the Java version which uses an “Enum Class” to represent each token type, the reimplementation should use the corresponding features of the chosen language. * In Scheme, this would simply be symbols. * In F#/OCaml, this would mean “Tagged Unions” (which F# calls Discriminated Unions).

# General Overview:

Write a program (in one of the languages listed above) which:

1. Accepts:

a. A space-delimited set of symbols representing a sentence to be represented as a parse tree. (The user should simply be prompted for the input to be entered via keyboard)

2. Outputs:

a. For successful parsing: “The Sentence <the sentence> follows the grammar.”

b. For unsuccessful parsing: “The Sentence <the sentence> is incorrect because: <reason for failure>”

BNF for parser (in ANTLR format) – MOSTLY the Same as for Program I.

# BNF for Program:

sentence : np vp np sentence_tail;

sentence_tail : conj sentence | eos;

np : art adj_list noun pp | noun;

adj_list : adj adj_tail | ε ;

adj_tail : comma adj_list | ε ;

pp : prep np | ε ;

vp : adv verb | verb;

// *** terminals ***

comma : ',';

eos : '.' | '!';

adj : 'fast' | 'slow' | 'furry' | 'yellow' ;

adv : 'quickly' | 'slowly' | 'quietly';

art : 'a' | 'the';

conj : 'and' | 'or';

noun : 'dog' | 'cat' | 'mouse' | 'tree' | 'cheese' ;

prep : 'of' | 'around';

verb : 'likes' | 'hates' | 'eats' | 'chases';
