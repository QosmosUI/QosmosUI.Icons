// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrMeta : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M2.562 14.676c0-3.929 1.965-8.028 4.27-8.028 1.282 0 2.307.768 3.93 3.074a1702.683 1702.683 0 0 1-2.477 3.844c-2.05 3.245-2.733 3.929-3.844 3.929-1.11.085-1.879-.94-1.879-2.819Zm13.41-1.452-1.452-2.391c-.342-.598-.77-1.196-1.11-1.708 1.28-1.965 2.305-2.99 3.586-2.99 2.563 0 4.613 3.844 4.613 8.627 0 1.793-.598 2.818-1.794 2.818-1.196 0-1.623-.769-3.844-4.356Zm-3.673-5.808C10.419 4.94 8.797 4 6.919 4 2.988 4 0 9.21 0 14.676c0 3.417 1.623 5.552 4.356 5.552 1.964 0 3.33-.94 5.893-5.381 0 0 1.025-1.879 1.794-3.16.256.427.512.854.768 1.366l1.196 2.05c2.306 3.929 3.587 5.21 5.893 5.21 2.648 0 4.1-2.22 4.1-5.722C23.915 8.783 20.84 4 17.167 4c-1.964 0-3.502 1.537-4.868 3.416Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
