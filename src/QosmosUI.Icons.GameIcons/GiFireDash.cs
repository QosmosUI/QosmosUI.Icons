// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFireDash : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M273.857 21.904c-24.193.012-51.198 5.552-81.1 17.467 143.7 12.608 150.35 129.263 84.032 132.814-85.27 4.565-53.232-57.217-133.34-103.03C200.445 201.48 94.44 190.33 21.054 59.23c12.805 85.755 24.28 116.942 78.26 153.596C261.996 323.294 94.618 347.8 36.82 245.53c14.568 93.454 68.364 132.803 131.707 139.93-42.753 24.49-99.452 32.49-143.01 25.556 51.025 42.317 131.606 40.94 193.515 8.576-37.137 36.123-97.446 70.644-116.803 74.728H276.36C517 405.563 530.305 232.45 454.827 124.492c-2.433 26.21-10.08 49.507-25.545 70.23-18.48-102.394-69.02-172.86-155.426-172.818zm2.82 184.666l141.384 52.155c.286-3.207.86-6.495 1.747-9.807 5.62-20.973 21.605-34.913 35.705-31.135 14.1 3.778 20.973 23.842 15.353 44.815-5.62 20.974-21.603 34.914-35.703 31.136-.725-.194-1.427-.442-2.113-.72l-60.58 49.394 70.637 19.584-140.023 84.71 65.848-68.866-31.32-7.006-150.335 122.58 158.06-196.89-137.39-41.137 137.006 5.654-68.275-54.467z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
