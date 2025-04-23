// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiWebtrees : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M2.957 4.34q.647 0 1.269.243.634.243 1.093.7.459.448.662 1l1.592 4.59 1.31-3.82Q9.84 4.26 11.92 4.26q.459 0 1.106.203.729.23 1.228.809.5.58.905 1.782l1.296 3.82 1.606-4.59q.189-.54.649-.998.472-.459 1.079-.703.608-.243 1.283-.243.62.04 1.241.338.783.378 1.228 1.106.459.73.459 1.66 0 .81-.364 1.54l-4.225 8.652q-1.025 2.106-3.037 2.106-.905-.04-1.634-.567-.728-.54-1.133-1.498L12 13.72l-1.606 3.955q-.243.634-.647 1.093-.406.447-.945.702-.54.257-1.134.27-1.013 0-1.755-.486-.742-.5-1.297-1.62L.392 8.983Q0 8.16 0 7.443q0-.89.46-1.632.459-.756 1.254-1.134.622-.297 1.243-.337Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
