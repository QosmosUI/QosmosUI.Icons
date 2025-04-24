// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMtr : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.987 1.913c-1.9 0-3.693.321-5.298.883C2.756 4.268 0 7.826 0 12c0 4.147 2.756 7.706 6.689 9.204 1.632.562 3.425.883 5.325.883a16.74 16.74 0 0 0 5.27-.856C21.217 19.759 24 16.174 24 12.027V12c0-4.174-2.783-7.732-6.716-9.204a16.295 16.295 0 0 0-5.297-.883zM10.89 5.257h2.167v3.827c1.525-.402 2.702-1.766 2.782-3.399l2.168.027c-.16 2.73-2.22 4.95-4.897 5.378v1.793c2.676.428 4.736 2.675 4.924 5.404l-2.167.028c-.08-1.633-1.258-2.997-2.783-3.425v3.853h-2.167V14.89a3.775 3.775 0 0 0-2.81 3.425l-2.167-.028a5.868 5.868 0 0 1 4.923-5.404v-1.766C8.187 10.716 6.1 8.468 5.94 5.74l2.167-.027A3.711 3.711 0 0 0 10.89 9.11Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
