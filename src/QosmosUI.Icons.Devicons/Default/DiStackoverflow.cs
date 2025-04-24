// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiStackoverflow : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M6.080 23.835v5.32h16.767v-10.673l-0.871 0.097-0.903 0.097-0.097 4.417-0.097 4.45h-13.188v-9.028h-1.612v5.32zM8.982 24.641v0.967h10.318v-1.935h-10.318v0.967zM9.137 20.832l-0.105 0.962 10.257 1.118 0.21-1.923-10.257-1.118-0.105 0.962zM9.908 16.282l-0.251 0.934 9.965 2.676 0.502-1.868-9.965-2.676-0.251 0.934zM12.024 10.978l-0.515 0.819 8.734 5.494 1.030-1.638-8.734-5.494-0.515 0.819zM16.965 6.038l-0.797 0.549 5.853 8.498 1.593-1.097-5.853-8.498-0.797 0.549zM23.413 3.549l-0.951 0.177 1.893 10.143 1.902-0.355-1.892-10.143-0.951 0.177z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
