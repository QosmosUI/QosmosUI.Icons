// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSteemit : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.982 7.246c-1-1-2.163-1.73-3.4-2.202.721-2.12 3.277-2.892 3.277-2.892S14.895-.944 8.31.29C6.114.64 4.008 1.988 2.468 3.768a9.152 9.152 0 0 0 .991 12.984c.598.512 1.934 1.308 1.958 1.349-.876 2.226-3.678 2.835-3.678 2.835s3.703 2.316 8.676 2.917c1.319.163 2.72.204 4.17.05 2.302-.188 4.596-1.406 6.34-3.12a9.525 9.525 0 0 0 .058-13.538zm-1.704 12.058c-1.41 1.382-3.515 2.26-5.137 2.381-1.147.114-2.376.13-3.555-.016-1.737-.212-2.99-.69-4.22-1.154.623-.601 1.246-1.43 1.5-2.145a1.652 1.652 0 0 0-.05-1.308 6.995 6.995 0 0 1 1.426-8.077 7.196 7.196 0 0 1 5.931-1.99 7.142 7.142 0 0 1 4.228 2.047c2.785 2.795 2.687 7.524-.123 10.262z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
