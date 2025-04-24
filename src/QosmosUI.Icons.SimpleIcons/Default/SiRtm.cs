// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRtm : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.584 9.054H1.98l-.487 1.413h3.408c.54 0 .594.25.51.494-.084.244-.18.323-.719.323h-3.43L0 14.946h1.917l.892-2.454c.263 0 .33.024.436.257l1.043 2.197h2.084l-1.148-2.46c1.368-.15 1.985-.822 2.206-1.698.211-.837-.173-1.734-1.846-1.734m2.817 0-.487 1.413H10l-1.541 4.48 2.036-.001 1.54-4.479h1.94l.486-1.413H8.4zm7.89 0h-1.306l-.485 1.414h.624c.272 0 .416.22.322.493l-1.368 3.985h2.036l1.37-3.988c.37-1.08.053-1.905-1.194-1.904m3.186 0h-1.16l-.486 1.414h.48c.271 0 .415.22.322.493l-1.368 3.985H19.3l1.37-3.988c.37-1.08.053-1.904-1.194-1.904m3.185 0h-1.16l-.485 1.414h.479c.272 0 .416.22.323.493l-1.369 3.985h2.036l1.37-3.988c.37-1.08.054-1.904-1.194-1.904");
		builder.CloseElement();
		builder.CloseElement();
    }
}
