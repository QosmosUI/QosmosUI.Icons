// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiExordo : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0a12 12 0 00-5.514 1.342l2.01 14.062 2.033-5.281a.375.375 0 01.334-.24.375.375 0 01.15.023.375.375 0 01.217.487L9.64 14.529 18.95 2.22a12 12 0 00-3.853-1.81l-.844 2.327-.318.828a.375.375 0 01-.485.215.375.375 0 01-.215-.484l.315-.822.812-2.239A12 12 0 0012 0zM5.785 1.736a12 12 0 00-5.691 8.762l.699.49a.375.375 0 01.09.524.375.375 0 01-.522.09l-.343-.243A12 12 0 000 12a12 12 0 001.129 5.078.375.375 0 01.21-.084l6.05-.422-5.213-3.693a.375.375 0 01-.088-.524.375.375 0 01.28-.158.375.375 0 01.243.069l5.205 3.691-2.03-14.22zm13.764.934L9.275 16.252l10.037-2.57-.126-.493a.375.375 0 01.27-.455.375.375 0 01.075-.011.375.375 0 01.38.279l.128.492 3.951-1.012A12 12 0 0024 12a12 12 0 00-4.451-9.33zm-7.48 1.607a.375.375 0 01.156.024l.826.316.826.315a.375.375 0 01.217.484.375.375 0 01-.485.215l-.826-.315-.828-.314a.375.375 0 01-.217-.484.375.375 0 01.33-.24zm.13 2.13a.375.375 0 01.155.023.375.375 0 01.214.484l-.271.711.389.148a.375.375 0 01.216.485.375.375 0 01-.482.217l-.393-.149-.091.238a.375.375 0 01-.485.215.375.375 0 01-.215-.484l.09-.236-.56-.215a.375.375 0 01-.217-.485.375.375 0 01.33-.24.375.375 0 01.154.024l.56.214.276-.71a.375.375 0 01.33-.24zm11.733 6.864l-3.705.95.127.49a.375.375 0 01-.27.459.375.375 0 01-.457-.27l-.127-.494-9.785 2.506 4.91 1.502a.375.375 0 01.248.467.375.375 0 01-.469.25l-4.922-1.504 1.032 1.17a.375.375 0 01-.034.53.375.375 0 01-.529-.034l-1.328-1.51-.52 5.567A12 12 0 0012 24a12 12 0 002.07-.18l-2.441-2.636-.303.265a.375.375 0 01-.53-.035.375.375 0 01.036-.53l.295-.257-.313-.354a.375.375 0 01.034-.529.375.375 0 01.252-.094.375.375 0 01.277.127l.312.354.383-.334a.375.375 0 01.252-.094.375.375 0 01.278.129.375.375 0 01-.036.53l-.373.327 2.729 2.95a12 12 0 005.164-2.772l-3.264-.998a.375.375 0 01-.25-.469.375.375 0 01.367-.265.375.375 0 01.102.017l3.654 1.118a12 12 0 003.237-6.999zM7.465 17.34l-5.912.562a12 12 0 002.728 3.285l.358-.427a.375.375 0 01.273-.137.375.375 0 01.256.086.375.375 0 01.049.527l-.344.416a12 12 0 002.5 1.418l.467-5.01-.559.678a.375.375 0 01-.527.051.375.375 0 01-.05-.527l.76-.922zm-2.541 1.88a.375.375 0 01.254.087l.681.562.684.563a.375.375 0 01.05.529.375.375 0 01-.529.05l-.681-.564-.682-.562a.375.375 0 01-.05-.528.375.375 0 01.273-.136Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
