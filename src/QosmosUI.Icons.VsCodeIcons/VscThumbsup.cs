// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscThumbsup : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M12.959 6H9.526L9.99 3.68C10.122 3.019 9.953 2.342 9.526 1.82C9.099 1.299 8.467 1 7.794 1C7.35 1 6.955 1.298 6.843 1.693L6.379 2.979C5.861 4.415 5.145 5.766 4.248 7H2.5C1.673 7 1 7.673 1 8.5V13.5C1 14.327 1.673 15 2.5 15H11.397C12.277 15 13.044 14.436 13.306 13.596L14.868 8.596C15.06 7.982 14.951 7.333 14.571 6.815C14.191 6.297 13.602 6 12.959 6ZM2 13.5V8.5C2 8.224 2.224 8 2.5 8H4V14H2.5C2.224 14 2 13.776 2 13.5ZM13.915 8.298L12.353 13.298C12.222 13.717 11.838 14 11.398 14H5.001V7.664C5.979 6.333 6.759 4.872 7.32 3.319L7.795 2.001C8.168 2.001 8.518 2.167 8.754 2.455C8.991 2.744 9.085 3.119 9.011 3.484L8.428 6.402C8.399 6.549 8.437 6.701 8.532 6.817C8.627 6.933 8.769 7 8.919 7H12.962C13.284 7 13.578 7.148 13.768 7.408C13.958 7.668 14.013 7.991 13.917 8.299L13.915 8.298Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
