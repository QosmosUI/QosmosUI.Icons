// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDocsify : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 2.862c-6.617 0-12 5.383-12 12 0 1.964.49 3.406 1.5 4.408 1.706 1.696 4.619 1.868 8.05 1.868.43 0 .87-.002 1.315-.005a217.6 217.6 0 0 1 2.765 0c3.792.024 7.066.044 8.88-1.758C23.511 18.378 24 16.9 24 14.862c0-6.617-5.383-12-12-12zm-8.852 8.154a.393.393 0 1 1 0-.787.393.393 0 0 1 0 .787zM5.113 8.48c-.55.637-1.01 1.361-1.01 1.361-.06.092-.167.099-.24.017l-.26-.29a.251.251 0 0 1-.02-.303s1.11-1.559 1.806-2.186c.25-.225.248-.239.891-.692.643-.453 1.4-.826 1.4-.826a.272.272 0 0 1 .308.059l.26.29c.075.082.056.186-.04.235 0 0-1.772.887-2.353 1.509-.394.422-.192.19-.742.826zm1.576 2.143a1.377 1.377 0 1 1 2.754 0 1.377 1.377 0 0 1-2.754 0zm5.41 7.929c-1.902 0-3.443-1.542-3.443-3.443s1.644-.854 3.545-.854 3.34-1.047 3.34.854-1.541 3.443-3.443 3.443zM16.72 12a1.377 1.377 0 1 1 0-2.754 1.377 1.377 0 0 1 0 2.754z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
