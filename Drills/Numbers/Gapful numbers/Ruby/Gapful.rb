class Integer
  def isGapful?
    number = self.to_s
    firstAndLast = (number[0] + number[-1]).to_i
    (self % firstAndLast).zero?
  end
end

puts 583.isGapful? # true : 583 % 53 = 0
puts 582.isGapful? # false : 582 % 52 = 10

puts "all gapful numbers from 100 - 1000"
(100..1000).each do |x|
  if x.isGapful?
    print x , " "
  end
end

